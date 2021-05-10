using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using WalletConnectSharp.Models;
using WalletConnectSharp.Client.Nethereum;
using System.Threading.Tasks;
using Websocket;
using Websocket.Client;

namespace WalletConnectSharp
{
    class Class1
    {
        public static void Main(string[] args)
        {

            UseFilterAddIfKeyPoolSizeIsZero();


        }
		public static void UseFilterAddIfKeyPoolSizeIsZero()
		{
            var metadata = new ClientMeta()
            {
                Description = "This is a test of the Nethereum.WalletConnect feature",
                Icons = new[] { "https://app.warriders.com/favicon.ico" },
                Name = "WalletConnect Test",
                URL = "https://app.warriders.com"
            };
            var connector = new WalletConnect(metadata);
            Task.WaitAll(connector.Connect());
            
		}
	}
}
