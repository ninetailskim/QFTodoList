//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QFramework.TodoList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using UnityEngine;
    using UnityEngine.UI;
    
    
    // Generate Id:97a328e8-107a-4377-a319-adced23200ad
    public partial class UITodoList
    {
        
        public const string NAME = "UITodoList";
        
        [SerializeField()]
        public UnityEngine.UI.InputField AddNewTodo;
        
        [SerializeField()]
        public UITodoitem UITodoitem;
        
        [SerializeField()]
        public UnityEngine.RectTransform Content;
        
        [SerializeField()]
        public UnityEngine.UI.Button BtnHave;
        
        private UITodoListData mPrivateData = null;
        
        public UITodoListData mData
        {
            get
            {
                return mPrivateData ?? (mPrivateData = new UITodoListData());
            }
            set
            {
                mUIData = value;
                mPrivateData = value;
            }
        }
        
        protected override void ClearUIComponents()
        {
            AddNewTodo = null;
            UITodoitem = null;
            Content = null;
            BtnHave = null;
            mData = null;
        }
    }
}
