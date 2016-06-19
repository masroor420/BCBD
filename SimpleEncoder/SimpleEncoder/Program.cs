using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SimpleEncoder
{
	class Program
	{
		private static IList<KeyValuePair<string, string>> prep()
		{
			return new List<KeyValuePair<string, string>>() 
			{
				new KeyValuePair<string, string> ("1JKJ'pz'{ol'{yhklthyr'vm'{ol'Jvu{yvs'Kh{h'Jvywvyh{pvu5", "*CDC is the trademark of the Control Data Corporation."),
				new KeyValuePair<string, string> ("1PIT'pz'h'{yhklthyr'vm'{ol'Pu{lyuh{pvuhs'I|zpulzz'Thjopul'Jvywvyh{pvu5", "*IBM is a trademark of the International Business Machine Corporation."),
				new KeyValuePair<string, string> ("1KLJ'pz'{ol'{yhklthyr'vm'{ol'Kpnp{hs'Lx|pwtlu{'Jvywvyh{pvu5", "*DEC is the trademark of the Digital Equipment Corporation.")

			};

		}

		private static int _diffAsciiValue = 0;
		private static Dictionary<char, int> _anomalies = new Dictionary<char, int>();

		static void Main(string[] args)
		{
			GetEncodingInfo();

			//Copy input.txt in bin/Debug folder
			string[] lines = File.ReadAllLines(@".\\input.txt");

			List<string> output = new List<string>();
			foreach (string line in lines)
			{
				output.Add(DecodeLine(line));
			}
			//output.txt will be written in bin/Debug folder
			File.WriteAllLines(@".\\output.txt", output.ToArray());

		}

		/// <summary>
		/// Decode strings using information collected earlier
		/// </summary>
		/// <param name="line"></param>
		/// <returns></returns>
		private static string DecodeLine(string line)
		{
			var builder = new StringBuilder();
			foreach (char c in line)
			{
				if (_anomalies.ContainsKey(c))
				{
					builder.Append(Convert.ToChar(c - _anomalies[c]));
				}
				else
				{
					builder.Append(Convert.ToChar(c - _diffAsciiValue));
				}
			}
			return builder.ToString();
		}

		/// <summary>
		/// Learn encoding using input and output strings provided.
		/// </summary>
		private static void GetEncodingInfo()
		{
			var crackInputs = prep();

			foreach (var input in crackInputs)
			{
				CrackEncoding(input.Key, input.Value);

				var builder = new StringBuilder();
				foreach (char c in input.Key)
				{
					if (_anomalies.ContainsKey(c))
					{
						builder.Append(Convert.ToChar(c - _anomalies[c]));
					}
					else
					{
						builder.Append(Convert.ToChar(c - _diffAsciiValue));
					}
				}
			}
		}

		/// <summary>
		/// We lock the first diff and all others diff is recorded as anomaly. 
		/// </summary>
		/// <param name="inputString"></param>
		/// <param name="outputString"></param>
		public static void CrackEncoding(string inputString, string outputString)
		{
			// If the length is same then both strings are possible ascii manipulation

			if (inputString.Length == outputString.Length)
			{
				int diff = 0;
				for (int i = 0; i < inputString.Length; i++)
				{
					diff = inputString[i] - outputString[i];

					if (i == 0)
					{
						_diffAsciiValue = diff;

					}
					if (diff == _diffAsciiValue)
					{
						continue;
					}
					else
					{
						// record all differences in Ascii value and associated characters if differenct from _diffAsciiValue.
						// Don't want to save everything because this will not be the master file for all characters.
						if (!_anomalies.ContainsKey(inputString[i]))
						{
							_anomalies.Add(inputString[i], diff);
						}
					}
				}
			}

		}
	}
}
