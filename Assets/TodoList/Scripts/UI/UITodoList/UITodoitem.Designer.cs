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

		public void Clear()
		{
			Completed = null;
			Contents = null;
		}

		public override string ComponentName
		{
			get { return "UITodoitem";}
		}
	}
}
