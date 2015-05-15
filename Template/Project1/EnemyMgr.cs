using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1 {
	class EnemyMgr {
		Enemy[] eneAry = new Enemy[64];
		EnemyOrder[] order = new EnemyOrder[]{
			new EnemyOrder(10, 100, 0, Math.PI/2),
			new EnemyOrder(10, 150, 0, Math.PI/2),		
			new EnemyOrder(10, 200, 0, Math.PI/2),
			new EnemyOrder(200, 60, 0, Math.PI/2),
			new EnemyOrder(220, 105, 0, Math.PI/2),
			new EnemyOrder(220, 160, 0, Math.PI/2),
			new EnemyOrder(200, 215, 0, Math.PI/2),
		};


		public EnemyMgr(){}

		public void Update(int gameCount){
			for(int i = 0; i < order.Length; i++){
				if(gameCount == order[i].spawnCount){
					for(int j = 0; j < eneAry.Length; j++){
						if(eneAry[j] == null){
							eneAry[j] = new Enemy(order[i].startX, order[i].startY, order[i].startAngle);
							break;
						}
					}
				}
			}
			
			for(int i = 0; i < eneAry.Length; i++){
				if(eneAry[i] != null){
					eneAry[i].Update();

					if(eneAry[i].isDead()){
						eneAry[i] = null;
					}
				}
			}
		}

		public void CollitionToMyChar(MyChar mychar){
			for(int i = 0; i < eneAry.Length; i++){
				if(eneAry[i] != null){
					if(mychar.JudgeCollition(eneAry[i])){
						mychar.Damage();
					}
				}
			}			
		}

		public void Draw(){
			for(int i = 0; i < eneAry.Length; i++){
				if(eneAry[i] != null){
					eneAry[i].Draw();
				}
			}		
		}

		public Enemy[] GetEnemy(){
			return eneAry;
		}
	}
}
