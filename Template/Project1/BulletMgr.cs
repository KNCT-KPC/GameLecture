using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1 {
	class BulletMgr {
		Bullet[] bltAry = new Bullet[256];

		public BulletMgr(){

		}

		public void Update(){
			for(int i = 0; i < bltAry.Length; i++){
				if(bltAry[i] != null){
					bltAry[i].Update();
					if(bltAry[i].isDead()){
						bltAry[i] = null;
					}
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

		public void AddBullet(Bullet blt){
			for(int i = 0; i < bltAry.Length; i++){
				if(bltAry[i] == null){
					bltAry[i] = blt;
					break;
				}
			}
		}
	}
}
