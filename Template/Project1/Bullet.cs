﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1 {
	class Bullet {
		private double x;
		private double y;
		private int colWidth;
		private int colHeight;
		private double angle;
		private bool live;

		public Bullet(double arg_x, double arg_y, double arg_angle){
			x = arg_x;
			y = arg_y;
			angle = arg_angle;

			colWidth = 16;
			colHeight = 30;
			live = true;
		}

		public void Update(){
			x += 10.0 * Math.Cos(angle);
			y += 10.0 * Math.Sin(angle);

			if(x > 640 || x < -colWidth || y > 480 || y < -colHeight){
				live = false;
			}
		}

		public void Draw(){
			Drawer.DrawRotaGraph((int)x+colWidth/2, (int)y+colHeight/2, 1.0, angle + Math.PI/2, "myshot1", true);
			Drawer.DrawRect((int)x, (int)y, colWidth, colHeight, new GameColor(0,255,0), false);
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

		public bool isDead(){
			return !live;
		}

		public void Kill(){
			live = false;
		}
	}
}
