using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1
{
	class MyChar
	{
		double x;
		double y;
		int colWidth;
		int colHeight;
		int graphWidth;
		int graphHeight;


		public MyChar(double arg_x, double arg_y){
			x = arg_x;
			y = arg_y;

			colWidth = 20;
			colHeight = 20;
			graphWidth = Drawer.GetGraphWidth("machine");
			graphHeight = Drawer.GetGraphHeight("machine");
		}
		public void Update(){
			double accel = 4.0;
			if((Keyboard.GetCount(Keyboard.KeyCode.CODE_UP) > 0 || Keyboard.GetCount(Keyboard.KeyCode.CODE_DOWN) > 0)
			&& (Keyboard.GetCount(Keyboard.KeyCode.CODE_LEFT) > 0 || Keyboard.GetCount(Keyboard.KeyCode.CODE_RIGHT) > 0)){
				accel /= Math.Sqrt(2);			
			}
			if (Keyboard.GetCount(Keyboard.KeyCode.CODE_UP) > 0){
                y -= accel;
            }
            if (Keyboard.GetCount(Keyboard.KeyCode.CODE_DOWN) > 0)
            {
                y += accel;
            }
            if (Keyboard.GetCount(Keyboard.KeyCode.CODE_LEFT) > 0)
            {
                x -= accel;
            }
            if (Keyboard.GetCount(Keyboard.KeyCode.CODE_RIGHT) > 0)
            {
                x += accel;
            }
		}

		public void Draw(){
			Drawer.DrawGraph((int)x-(graphWidth/2-colWidth/2), (int)y-(graphHeight/2-colHeight/2), "machine", true);
			Drawer.DrawRect((int)x, (int)y, colWidth, colHeight, new GameColor(0,255,0), false);
		}
	}
}