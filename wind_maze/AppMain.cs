using System;
using System.Collections.Generic;

using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.Core.Graphics;
using Sce.PlayStation.Core.Input;
using Sce.PlayStation.HighLevel.GameEngine2D;

namespace wind_maze
{
	public class AppMain
	{
		private static Scene scene;
		
		public static void Main (string[] args)
		{
			Initialize ();
			
			// start main loop
			Director.Instance.RunWithScene (scene);
		}

		public static void Initialize ()
		{
			Director.Initialize ();
			scene = new Scene ();
			
			// set backgound color as white
			Director.Instance.GL.Context.SetClearColor (1.0f, 1.0f, 1.0f, 0.0f);
		}
	}
}
