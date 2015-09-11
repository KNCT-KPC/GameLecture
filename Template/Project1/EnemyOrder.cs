using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1 {
	class EnemyOrder {
		public int spawnCount;
		public int startX;
		public int startY;
		public double startAngle;

		public int life;
		public string graphName;

		public EnemyOrder(int arg_spawnCount, int arg_startX, int arg_startY, double arg_startAngle, int arg_life, string arg_graphName){
			spawnCount = arg_spawnCount;
			startX = arg_startX;
			startY = arg_startY;
			startAngle = arg_startAngle;
			life = arg_life;
			graphName = arg_graphName;
		}
	}
}
