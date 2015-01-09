using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1 {
	class BulletMgr {
		Bullet[] bltAry = new Bullet[256];

		public BulletMgr(){
			bltAry[0] = new Bullet(100,200,Math.PI/2*3);
			bltAry[1] = new Bullet(150,200,Math.PI/2*3);
			bltAry[2] = new Bullet(200,200,Math.PI/2*3);
		}

		public void Update(){
			for(int i = 0; i < bltAry.Length; i++){
				if(bltAry[i] != null){
					bltAry[i].Update();
				}
			}
		}

		public void Draw(){
			for(int i = 0; i < bltAry.Length; i++){
				if(bltAry[i] != null){
					bltAry[i].Draw();
				}
			}
		}

		public void CollitionToEnemy(Enemy[] eneAry){
			for(int j = 0; j < bltAry.Length; j++){
				if(bltAry[j] != null){
					for(int i = 0; i < eneAry.Length; i++){
						if(eneAry[i] != null){
							if(bltAry[j].JudgeCollition(eneAry[i])){
								eneAry[i].Damage();
							}
						}
					}
				}
			}
		}
	}
}
