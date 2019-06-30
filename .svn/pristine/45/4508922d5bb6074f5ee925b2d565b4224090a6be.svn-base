using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Videotheque.DataAccess;
using Videotheque.Utils;

namespace Videotheque.Tools
{
    public class ToolsDataController<T> : ToolsBinding where T : ToolsDataController<T>
    {

        public static async Task<string> CountData(Func<T, bool> predicat = null)
        {
            DbService db = await DbService.getInstance();
            int returnValue = predicat != null ? db.Set<T>().Where(predicat).ToList().Count() : db.Set<T>().ToList().Count();
            return returnValue.ToString();
        }

        public static async Task<List<T>> GetData(Func<T, bool> where = null)
        {
            DbService db = await DbService.getInstance();
            return where != null ? db.Set<T>().Where(where).ToList() : db.Set<T>().ToList();
        }
    }
}
