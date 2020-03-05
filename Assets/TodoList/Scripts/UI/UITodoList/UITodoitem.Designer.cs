/****************************************************************************
 * 2020.2 DESKTOP-H5GOJS7
 ****************************************************************************/

using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace QFramework.TodoList
{
	public partial class UITodoitem
	{
		[SerializeField] public UnityEngine.UI.Toggle Completed;
		[SerializeField] public UnityEngine.UI.Text Contents;
		[SerializeField] public UnityEngine.UI.Button Button;

		public void Clear()
		{
			Completed = null;
			Contents = null;
			Button = null;
		}

		public override string ComponentName
		{
			get { return "UITodoitem";}
		}
	}
}
