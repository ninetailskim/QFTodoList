/****************************************************************************
 * 2020.2 DESKTOP-H5GOJS7
 ****************************************************************************/

using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace QFramework.TodoList
{
	public partial class UICompletedTodoitem
	{
		[SerializeField] public UnityEngine.UI.Text Contents;
		[SerializeField] public UnityEngine.UI.Button BtnRemark;

		public void Clear()
		{
			Contents = null;
			BtnRemark = null;
		}

		public override string ComponentName
		{
			get { return "UICompletedTodoitem";}
		}
	}
}
