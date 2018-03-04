using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using umbraco.NodeFactory;
using Umbraco.Web.WebApi;

namespace Umbraco.Web.UI
{
    public class ContentController : UmbracoApiController
    {
        public Node GetAllProducts(int id = 1103)
        {
            Node driverParentNode = new Node(id);
            return driverParentNode ;
        }

    }
}
