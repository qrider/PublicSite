using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace quentinrider.Lib.UI
{
    public class CssStylesRenderer
    {
        private IEnumerable<string> _collection = new List<string>();
        private const string TAG = "<link rel='stylesheet' type='text/css' href='{0}' >";
        

        public void Add(params string[] filerefs){            
            _collection = _collection.Concat(filerefs.ToList());
        }
        public override string ToString()
        { 
            StringBuilder sb = new StringBuilder();

            foreach(var i in _collection){
                sb.Append(string.Format(TAG, VirtualPathUtility.ToAbsolute(i)));         
            }
            return sb.ToString();
        }
    }
}