using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Band;
using Microsoft.Band.Portable;
namespace XamarinBandApp
{
	public class BandHelper
	{
		private static List<BandDeviceInfo> _myBands = null;
		private static BandClient myBandClient = null;
		public static List<BandDeviceInfo> MyBands
		{
			get
			{
				if (_myBands == null)
				{
					GetConnectedBands();
				}
				return _myBands;
			}
		}
		public BandHelper()
		{
				
		}

		async static void GetConnectedBands()
		{
			IEnumerable<BandDeviceInfo> myBands =  await BandClientManager.Instance.GetPairedBandsAsync();
			_myBands = new List<BandDeviceInfo>(myBands);
		}

		public static bool ConnectToBand()
		{
			Task<BandClient> bc;
			try
			{
				bc = BandClientManager.Instance.ConnectAsync(_myBands[0]);
				bc.Wait();
				if (bc.IsCompleted)
				{
					myBandClient = bc.Result;
					return true;
				}
				else
				{
					return false;
				}
			}
			catch (BandException)
			{
				return false;
			}
		}
	}
}

