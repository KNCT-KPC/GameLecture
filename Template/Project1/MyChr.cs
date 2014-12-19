using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1
{
	class MyChar
	{
		private double x;
		double y;
		int colWidth;
		int colHeight;
		int graphWidth;
		int graphHeight;
		private int life;
		private int invinCount;

		public MyChar(double arg_x, double arg_y){
			x = arg_x;
			y = arg_y;

			invinCount = 0;
			life = 5;
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
			
			if(invinCount > 0){
				invinCount = invinCount-1;
			}
		}

		public void Draw(){
			if((invinCount/8)%2 == 0){
				Drawer.DrawGraph((int)x-(graphWidth/2-colWidth/2), (int)y-(graphHeight/2-colHeight/2), "machine", true);
			}

			Drawer.DrawRect((int)x, (int)y, colWidth, colHeight, new GameColor(0,255,0), false);
			Drawer.DrawString(0, 0, life+"", new GameColor(255, 255, 255), "SystemFont");
		}

		public double GetX(){
			return x;
		}
		public double GetY(){
			return y;
		}
		public int GetColWidth(){
			return colWidth;
		}
		public int GetColHeight(){
			return colHeight;
		}

		public bool JudgeCollition(Enemy enemy){
			double X0 = enemy.GetX();
			double Y0 = enemy.GetY();
			double X1 = X0 + enemy.GetColWidth();
			double Y1 = Y0 + enemy.GetColHeight();
			double x0 = x;
			double y0 = y;
			double x1 = x0 + colWidth;
			double y1 = y0 + colHeight;

			if(x1 > X0 && X1 > x0 && y1 > Y0 && Y1 > y0){
				return true;
			}
			return false;
		}

		public void Damage(){
			if(invinCount == 0){
				life = life-1;
				invinCount = 160;
			}
		}
	}
}