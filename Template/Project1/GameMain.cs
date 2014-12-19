using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1 {
	//ゲームのプログラムを記述するクラス
	class GameMain {
		MyChar mychar = new MyChar(150,400);
		EnemyMgr eneMgr = new EnemyMgr();
		Bullet bullet = new Bullet(200,200,0);

		public GameMain(){
		}
		

		/// <summary>
		/// 更新メソッド
		/// 状態の更新や演算処理などを記述する
		/// 
		/// 戻り値として0以外を返すとゲームが終了する
		/// </summary>
		public int Update(){
			mychar.Update();
			eneMgr.Update();
			bullet.Update();

			eneMgr.Collition(mychar);
			return 0;
		}

		/// <summary>
		/// 描画メソッド
		/// 画像の描画を行う
		/// </summary>
		public void Draw(){
			mychar.Draw();
			eneMgr.Draw();
			bullet.Draw();
		}
	}
}
