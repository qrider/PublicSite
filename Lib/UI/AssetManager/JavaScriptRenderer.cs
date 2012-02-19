using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace quentinrider.Lib.UI
{
    public class JavaScriptRenderer
    {
        private IEnumerable<string> _collection = new List<string>();
        private const string START_TAG = "<script type='text/javascript' src='{0}' >";
        private const string END_TAG = "</script>";

        public void Add(params string[] filerefs)
        {
            _collection = _collection.Concat(filerefs.ToList());
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var i in _collection)
            {
                sb.Append(string.Format(START_TAG, VirtualPathUtility.ToAbsolute(i)));
                sb.Append(END_TAG);
            }
            return sb.ToString();
        }
    }
}