using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class ResultEntity
    {
        public HttpStatusCode Code { get; set; }
        public string Infomation {  get; set;}
        public object Entity { get; set; }

        public ResultEntity(object Entity = null, string Infomation="操作成功！", HttpStatusCode code = HttpStatusCode.OK)
        {
            this.Code = code;
            this.Entity = Entity;
            this.Infomation = Infomation;
        }
    }
}
