using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1 {
	class Enemy {
		private double x;
		private double y;
		private double angle;
		int colWidth;
		int colHeight;
		int life;

		public Enemy(double arg_x, double arg_y, double arg_angle){
			x = arg_x;
			y = arg_y;
			angle = arg_angle;

			colWidth = 20;
			colHeight = 20;
			life = 1;
		}

		public void Update(){
			x += 2.0 * Math.Cos(angle);
			y += 2.0 * Math.Sin(angle);
		}

		public void Draw(){
			Drawer.DrawRotaGraph((int)x+colWidth/2, (int)y+colHeight/2, 1.0, angle + Math.PI/2, "zakoEnemy1", true);
			Drawer.DrawRect((int)x, (int)y, colWidth, colHeight, new GameColor(0,255,0), false);
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

		public void Damage(){
			life = life - 1;
		}

		public bool isDead(){
			if(life == 0){
				return true;
			}
			return false;
		}
	}
}
