using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace ITHero
{
	/// <summary>
	/// 游戏管理类
	/// </summary>
	static class GameManager
	{
		//静态游戏对象
		public static Game GameInfo = new Game();
		/// <summary>
		/// 存档
		/// </summary>
		/// <returns></returns>
		public static void Save()
		{
			//创建文件流
			FileStream fs = new FileStream(@"data/"+GameManager.GameInfo.Hero.Name+".dat",FileMode.Create,FileAccess.Write);
			BinaryFormatter bf = new BinaryFormatter();
			//序列化
			bf.Serialize(fs,GameManager.GameInfo);
			fs.Close();
		}
		/// <summary>
		/// 读档
		/// </summary>
		public static void Load(string fileName)
		{
			//创建文件流
			FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
			BinaryFormatter bf = new BinaryFormatter();
			//反序列化
			GameManager.GameInfo = bf.Deserialize(fs) as Game;
			fs.Close();
		}
	}
}
