using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1 {
	class EnemyMgr {
		Enemy[] eneAry = new Enemy[64];

		public EnemyMgr(){
			eneAry[0] = new Enemy(100,100,Math.PI/2);
			eneAry[1] = new Enemy(150,100,Math.PI/2);
			eneAry[2] = new Enemy(200,100,Math.PI/2);			
		}

		public void Update(){
			for(int i = 0; i < eneAry.Length; i++){
				if(eneAry[i] != null){
					eneAry[i].Update();
				}
			}			
		}

		public void Collition(MyChar mychar){
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
	}
}
