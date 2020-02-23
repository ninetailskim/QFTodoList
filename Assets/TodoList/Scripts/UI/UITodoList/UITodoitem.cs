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
	public partial class UITodoitem : UIElement
	{
        TodoItem mModel;

        public void Init(TodoItem model)
        {
            mModel = model;
            Contents.text = mModel.Content;
            Completed.isOn = mModel.Completed;

            Completed.onValueChanged.AddListener(on =>
            {
                mModel.Completed = on;
                SendEvent(UITodoListEvent.OnDataChanged);
            });
        }

		private void Awake()
		{
		}

		protected override void OnBeforeDestroy()
		{
		}
	}
}