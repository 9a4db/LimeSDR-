using System;
using System.Diagnostics;

namespace PowerSDR
{
	/// <summary>
	/// Summary description for filter.
	/// </summary>
	public class FilterPreset
	{
		private int[] low;
		private int[] high;
		private string[] name;

		public FilterPreset()
		{			
			low = new int[(int)Filter.LAST];
			high = new int[(int)Filter.LAST];
			name = new string[(int)Filter.LAST];
		}
	
		public void SetLow(Filter f, int val)
		{
			low[(int)f] = val;
		}

		public void SetHigh(Filter f, int val)
		{
			high[(int)f] = val;

            if (val == 1170)
            {

            }
		}

		public void SetName(Filter f, string n)
		{
			name[(int)f] = n;
		}

		public void SetFilter(Filter f, int l, int h, string n)
		{
			low[(int)f] = l;
			high[(int)f] = h;
			name[(int)f] = n;
		}

		public int GetLow(Filter f)
		{
			return low[(int)f];
		}

		public int GetHigh(Filter f)
		{
			return high[(int)f];
		}

		public string GetName(Filter f)
		{
			return name[(int)f];
		}

		private Filter last_filter;
		public Filter LastFilter
		{
			get { return last_filter; }
			set { last_filter = value; }
		}

		public string ToString(Filter f)
		{
			return name[(int)f]+": "+low[(int)f].ToString()+", "+high[(int)f].ToString();
		}

        public bool CopyFilter(Filter source, int f_low, int f_high, Filter f_last, string f_name)       // yt7pwr
        {
            try
            {
                high[(int)source] = f_high;
                low[(int)source] = f_low;
                last_filter = f_last;
                name[(int)source] = f_name;
                return true;
            }
            catch (Exception ex)
            {
                Debug.Write(ex.ToString());
                return false;
            }
        }
	}
}
