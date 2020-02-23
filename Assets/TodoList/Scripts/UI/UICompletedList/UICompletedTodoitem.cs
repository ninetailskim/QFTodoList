/****************************************************************************
 * 2020.2 DESKTOP-H5GOJS7
 ****************************************************************************/

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace QFramework.TodoList
{
	public partial class UICompletedTodoitem : UIElement
	{
		private void Awake()
		{
		}

		protected override void OnBeforeDestroy()
		{
		}
        TodoItem mModel;

        internal void Init(TodoItem model)
        {
            mModel = model;
            Contents.text = mModel.Content;

            BtnRemark.onClick.AddListener(()=> 
            {
                mModel.Completed = false;
                SendEvent(UICompletedListEvent.OnDataChanged);
            });
        }
    }
}