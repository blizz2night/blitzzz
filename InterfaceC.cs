        #region 控制云镜
        /// <summary>
        /// 控制云镜
        /// </summary>
        /// <returns></returns>
        public static byte[] ControlPTZ()
        {

            String str = System.IO.File.ReadAllText(@"../../SIP+XML/B/ControlPTZ.txt");
            byte[] temp = Encoding.UTF8.GetBytes(str);
            return temp;
        }
        /// <summary>
        /// 控制云镜（重载方法）
        /// </summary>
        /// <param name="socket"></param>
        /// <param name="sendBuffer"></param>
        /// <param name="revBuffer"></param>
        /// <remarks>返回 String 类型的回传消息</remarks>
        /// <returns></returns>
        public  static String ControlPTZ(Socket socket,byte[] sendBuffer,byte[] revBuffer)
        {
            try
            {   
                String sendStr = System.IO.File.ReadAllText(@"../../SIP+XML/B/ControlPTZ.txt");
                sendBuffer = Encoding.UTF8.GetBytes(sendStr);
                //return sendbuffer;
                socket.Send(sendBuffer);
                socket.Receive(revBuffer);
                String revStr = Encoding.UTF8.GetString(revBuffer);
                return revStr;
            }
            catch (SocketException se)
            {
                //Console.WriteLine(se.SocketErrorCode);
                //Console.WriteLine(se.ToString());
                return null;
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.ToString());
                return null;
            }
            
        }
        /// <summary>
        /// 控制云镜（重载方法）
        /// </summary>
        /// <param name="socket"></param>
        /// <param name="sendBuffer"></param>
        /// <param name="receiveBuffer"></param>
        /// <remarks>返回 byte[] 类型的回传消息</remarks>
        /// <returns></returns>
        public static byte[] ControlPTZ(Socket socket, byte[] sendBuffer, byte[] revBuffer)
        {
            try
            {
                String sendStr = System.IO.File.ReadAllText(@"../../SIP+XML/B/ControlPTZ.txt");
                sendBuffer = Encoding.UTF8.GetBytes(sendStr);
                //return sendbuffer;
                socket.Send(sendBuffer);
                socket.Receive(revBuffer);
                return revBuffer;
            }
            catch (SocketException se)
            {
                Console.WriteLine(se.SocketErrorCode);
                Console.WriteLine(se.ToString());
                return null;
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.ToString());
                return null;
            }

        }

        #endregion

        #region 停止视频传输
        /// <summary>
        /// 停止视频传输
        /// </summary>
        /// <returns></returns>
        public static byte[] StopMediaReq()
        {
            try
            {
                String str = System.IO.File.ReadAllText(@"../../SIP+XML/B/StopMediaReq.txt");
                byte[] temp = Encoding.UTF8.GetBytes(str);
                return temp;
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.ToString());
                return null;
            }
        }
        /// <summary>
        /// 停止视频传输（重载方法）
        /// </summary>
        /// <param name="socket"></param>
        /// <param name="sendBuffer"></param>
        /// <param name="revBuffer"></param>
        /// <remarks>返回 string 类型的回传消息</remarks>
        /// <returns></returns>
        public static string StopMediaReq(Socket socket, byte[] sendBuffer, byte[] revBuffer)
        {
            try
            {
                String sendStr = System.IO.File.ReadAllText(@"../../SIP+XML/B/StopMediaReq.txt");
                sendBuffer = Encoding.UTF8.GetBytes(sendStr);
                //return sendbuffer;
                socket.Send(sendBuffer);
                socket.Receive(revBuffer);
                String revStr = Encoding.UTF8.GetString(revBuffer);
                return revStr;
            }
            catch (SocketException se)
            {
                //Console.WriteLine(se.SocketErrorCode);
                //Console.WriteLine(se.ToString());
                return null;
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.ToString());
                return null;
            }

        }
        /// <summary>
        /// 停止视频传输（重载方法）
        /// </summary>
        /// <param name="socket"></param>
        /// <param name="sendBuffer"></param>
        /// <param name="receiveBuffer"></param>
        /// <remarks>返回 byte[] 类型的回传消息</remarks>
        /// <returns></returns>
        public static byte[] StopMediaReq(Socket socket, byte[] sendBuffer, byte[] revBuffer)
        {
            try
            {
                String sendStr = System.IO.File.ReadAllText(@"../../SIP+XML/B/StopMediaReq.txt");
                sendBuffer = Encoding.UTF8.GetBytes(sendStr);
                //return sendbuffer;
                socket.Send(sendBuffer);
                socket.Receive(revBuffer);
                return revBuffer;
            }
            catch (SocketException se)
            {
                Console.WriteLine(se.SocketErrorCode);
                Console.WriteLine(se.ToString());
                return null;
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.ToString());
                return null;
            }

        }



        #endregion