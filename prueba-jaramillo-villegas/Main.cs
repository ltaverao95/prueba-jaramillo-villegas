using prueba_jaramillo_villegas.Common;
using prueba_jaramillo_villegas.DTO;
using prueba_jaramillo_villegas.EntityModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace prueba_jaramillo_villegas
{
    public partial class Main : Form
    {
        #region Properties

        Socket _socket;
        IPAddress _ipAdd;
        IPEndPoint _remoteEndPoint;

        ManualResetEvent _connectDone;
        ManualResetEvent _closeDone;
        ManualResetEvent _receiveDone;
        ManualResetEvent _sendDone;

        DataTable _dataTable = new DataTable();
        BasculaEntities _dataBase = new BasculaEntities();

        #endregion

        #region Public Methods

        public Main()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        #endregion

        #region Private Methods

        private void Main_Load(object sender, EventArgs e)
        {
            _connectDone = new ManualResetEvent(false);
            _closeDone = new ManualResetEvent(false);
            _receiveDone = new ManualResetEvent(false);
            _sendDone = new ManualResetEvent(false);

            _dataTable.Columns.Add("Id").AutoIncrement = true;
            _dataTable.Columns.Add("variable").ColumnName = "Variable";
            _dataTable.Columns.Add("date");

            dataGridResults.DataSource = _dataTable;
        }

        private void btn_init_con_Click(object sender, EventArgs e)
        {
            InitConnection();
            ReceiveDataFromSocket();
        }

        private void btn_stop_connection_Click(object sender, EventArgs e)
        {
            CloseConnection();
        }

        private void InitConnection()
        {
            try
            {
                _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _ipAdd = IPAddress.Parse(Constants.HOST_IP);
                _remoteEndPoint = new IPEndPoint(_ipAdd, Constants.HOST_PORT);

                _socket.BeginConnect(_remoteEndPoint,
                                     new AsyncCallback(InitConnectionCallback), _socket);

                _connectDone.WaitOne();
            }
            catch (Exception ex)
            {
                MessageBox.Show("A ocurrido un error conectando con el socket");
            }
        }

        private void InitConnectionCallback(IAsyncResult asyncResult)
        {
            try
            {
                Socket client = (Socket)asyncResult.AsyncState;

                client.EndConnect(asyncResult);

                lbl_con_result.Text = string.Format("Conectado al socket {0}", client.RemoteEndPoint.ToString());

                _connectDone.Set();
            }
            catch (Exception e)
            {
                MessageBox.Show("A ocurrido un error conectando con el socket");
            }
        }

        private void CloseConnection()
        {
            try
            {
                StateObjectDTO state = new StateObjectDTO();
                state.workSocket = _socket;

                _socket.BeginDisconnect(false, 
                                        new AsyncCallback(CloseConnectionCallback), state);

                _closeDone.WaitOne();
            }
            catch (Exception ex)
            {
                MessageBox.Show("A ocurrido un error desconectando con el socket");
            }
        }

        private void CloseConnectionCallback(IAsyncResult asyncResult)
        {
            try
            {
                StateObjectDTO state = (StateObjectDTO)asyncResult.AsyncState;
                Socket client = state.workSocket;

                client.EndDisconnect(asyncResult);

                lbl_con_result.Text = "Conexión cerrada";

                client.Disconnect(false);

                _closeDone.Set();
            }
            catch (Exception e)
            {
                MessageBox.Show("A ocurrido un error conectando con el socket");
            }
        }

        private void ReceiveDataFromSocket()
        {
            try
            {
                StateObjectDTO state = new StateObjectDTO();
                state.workSocket = _socket;

                _socket.BeginReceive(state.buffer, 0, StateObjectDTO.BufferSize, 0,
                                     new AsyncCallback(ReceiveDataFromSocketCallback), state);
            }
            catch (Exception e)
            {
                MessageBox.Show("A ocurrido un error recibiendo los datos");
            }
        }

        private void ReceiveDataFromSocketCallback(IAsyncResult asyncResult)
        {
            try
            {
                StateObjectDTO state = (StateObjectDTO)asyncResult.AsyncState;
                Socket client = state.workSocket;

                if(!client.Connected)
                {
                    client.EndReceive(asyncResult);

                    _receiveDone.Set();
                    return;
                }

                int bytesRead = client.EndReceive(asyncResult);
                if (bytesRead > 0)
                {
                    if (state.stringBuilder.Length == 0)
                    {
                        state.stringBuilder.Append(Encoding.ASCII.GetString(state.buffer, 0, bytesRead));

                        client.BeginReceive(state.buffer, 0, StateObjectDTO.BufferSize, 0, new AsyncCallback(ReceiveDataFromSocketCallback), state);

                        return;
                    }

                    string currentData = state.stringBuilder.ToString().Substring(state.stringBuilder.ToString().IndexOf("INIVARS0$"), state.stringBuilder.ToString().IndexOf("$FINVARS") + 8);

                    string[] currentDataArr = currentData.Split('$');

                    List<string> currentDataList = currentDataArr.ToList();
                    currentDataList.Remove("INIVARS0");
                    currentDataList.Remove("FINVARS");

                    for (int i = 0; i < currentDataList.Count; i++)
                    {
                        _dataTable.Rows.Add(null, currentDataList[i], DateTime.Now);
                        _dataBase.InserDataProcedure(currentDataList[i], DateTime.Now);
                    }

                    state.stringBuilder.Append(Encoding.ASCII.GetString(state.buffer, 0, bytesRead));

                    client.BeginReceive(state.buffer, 0, StateObjectDTO.BufferSize, 0,
                                        new AsyncCallback(ReceiveDataFromSocketCallback), state);
                }
                else
                {
                    client.EndReceive(asyncResult);

                    _receiveDone.Set();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("A ocurrido un error recibiendo los datos");
            }
        }

        #endregion
    }
}
