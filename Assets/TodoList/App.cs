using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
//add one commend
//ADD TWO COMMEND

//add new commend

//add three commend

namespace QFramework.TodoList
{
    public class App : MonoBehaviour
    {

        TodoList mModel;
        // Start is called before the first frame update
        void Start()
        {
            mModel = TodoList.Load();

            ResMgr.Init();

            UIMgr.SetResolution(640, 1136, 0);

            UIMgr.OpenPanel<UITodoList>(new UITodoListData()
            {
                Model = mModel
            });
        }

        // Update is called once per frame

        void OnApplicationQuit()
        {
            //mModel.mTodoitem.ForEach(item =>
            //{
            //    Debug.Log(item.Content);
            //});
            mModel.Save();
            Debug.Log("OnApplicationQuit!!!");
        }



    }

    public class TodoList
    {
        public List<TodoItem> mTodoitem = new List<TodoItem>();
        //{
        //    new TodoItem(){Completed=false, Content="Good"},
        //    new TodoItem(){Completed=false, Content="Great"},
        //    new TodoItem(){Completed=false, Content="Amazing"},
        //    new TodoItem(){Completed=true, Content="Superme"}
        //};

        public static TodoList Load()
        {
            var jsonContent = PlayerPrefs.GetString("TodoListData", string.Empty);
            Debug.Log(jsonContent);
            if (jsonContent.IsNullOrEmpty())
            {
                return new TodoList();
            }
            else {
                //return JsonUtility.FromJson<TodoList>(jsonContent);
                return JsonConvert.DeserializeObject<TodoList>(jsonContent);
                //return jsonContent.FromJson<TodoList>();
            }
        }

        public void Save()
        {
            Debug.Log("Save!!!");
            Debug.Log(JsonUtility.ToJson(this.ToString()));
            //PlayerPrefs.SetString("TodoListData", JsonUtility.ToJson(this));
            PlayerPrefs.SetString("TodoListData", JsonConvert.SerializeObject(this));
            //JsonUtility.ToJson
        }
    }

    public class TodoItem
    {
        public bool Completed;

        public string Content;
    }
}
