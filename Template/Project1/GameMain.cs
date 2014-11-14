using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1 {
	//ゲームのプログラムを記述するクラス
	class GameMain {
		MyChar mychar = new MyChar(150,400);
		Enemy enemy = new Enemy(100,100,Math.PI/2);

		/// <summary>
		/// 更新メソッド
		/// 状態の更新や演算処理などを記述する
		/// 
		/// 戻り値として0以外を返すとゲームが終了する
		/// </summary>
		public int Update(){
			mychar.Update();
			enemy.Update();

			if(mychar.JudgeCollition(enemy)){
				mychar.Damage();
			}
			return 0;
		}

		/// <summary>
		/// 描画メソッド
		/// 画像の描画を行う
		/// </summary>
		public void Draw(){
			mychar.Draw();
			enemy.Draw();
		}
	}
}
