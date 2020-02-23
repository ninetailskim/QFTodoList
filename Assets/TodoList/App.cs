using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QFramework;

namespace QFramework.TodoList
{
    public class App : MonoBehaviour
    {

        public TodoList Model = new TodoList();
        // Start is called before the first frame update
        void Start()
        {
            ResMgr.Init();
            UIMgr.SetResolution(640, 1136, 0);
            UIMgr.OpenPanel<UITodoList>(new UITodoListData() {
                Model = Model
            });
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

    public class TodoList
    {
        public List<TodoItem> mTodoitem = new List<TodoItem>() {
            new TodoItem(){Completed=false, Content="Good"},
            new TodoItem(){Completed=false, Content="Great"},
            new TodoItem(){Completed=false, Content="Amazing"},
            new TodoItem(){Completed=true, Content="Superme"}
        };
    }

    public class TodoItem
    {
        public bool Completed;

        public string Content;
    }
}
