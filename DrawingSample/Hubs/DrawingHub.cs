using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace DrawingSample.Hubs
{
    [HubName("drawingHub")]
    public class DrawingHub : Hub
    {
        public void UpdateCanvas(int x, int y)
        {
            Clients.All.updateDot(x, y);
        }

        public void ClearAllCanvas()
        {
            Clients.All.clearAllCanvas();
        }

        public void DrawMove(int[] p, string color)
        {
            Clients.Others.drawMove(p, color);
        }
    }
}