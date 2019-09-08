using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ResultEntity<T> where T:class
    {
        public HttpStatusCode Code { get; set; }
        public string Infomation { get; set;}
        public T Entity { get; set; }

        public ResultEntity(T Entity = null, string Infomation="操作成功！", HttpStatusCode code = HttpStatusCode.OK)
        {
            this.Code = code;
            this.Entity = Entity;
            this.Infomation = Infomation;
        }
    }
}
