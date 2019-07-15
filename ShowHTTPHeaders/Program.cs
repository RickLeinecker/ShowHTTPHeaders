using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ShowHTTPHeaders
{
	class Program
	{
		static void Main(string[] args)
		{

			if( args.Length < 1 )
			{
				Console.WriteLine("You need to specify at least one URL.");
				return;
			}

			foreach (string s in args)
			{
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create(s);
				request.Method = "GET";
				HttpWebResponse response = (HttpWebResponse)request.GetResponse();
				Console.WriteLine(response.Headers);
			}

		}
	}
}
