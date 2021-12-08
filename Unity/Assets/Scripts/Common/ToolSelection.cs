using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


namespace Drawing
{
    public class ToolSelection : MonoBehaviour
    {

///////////////////////////////////
/// ToolSaver and ColorSaver
        /* �I�𒆂̃c�[����ێ� �����l:0(Pen)
                   Pen=0   Highrighter=1 
                Eraser=2 Constractions=3
        */
        public enum Toolmode
        {
            Pen=0,
            Highlighter=1,
            Eraser=2,
            Constractions=3
        }
        public static Toolmode UsingTool = Toolmode.Pen;

        // UsingToolGeter
        public static int GetUsingTool()
        {
            return (int)UsingTool;
        }

        /////
        //// �I�𒆂̃J���[�s�b�J�[�̕ێ�
        //public enum ColorPicker
        //{
        //    first=0,
        //    second=1,
        //    third=2
        //}
        //public static ColorPicker CurColor = ColorPicker.first;


//////////////////////////////////////////////////////////////
/// �{�^��



        // �c�[���ύX
        public void ChangeTool_Pen()
        {
            if ( UsingTool != Toolmode.Pen)
            {
                UsingTool = Toolmode.Pen;
                Color c = InputSystem_Drawable.PenColor; //�Ƃ肠�����̎��� ��ŕς���
                InputSystem_Drawable.UsingColor = c;


            }
        }

        public void ChangeTool_High()
        {
            if ( UsingTool != Toolmode.Highlighter)
            {
                UsingTool = Toolmode.Highlighter;
                Color c = InputSystem_Drawable.HighColor;
                InputSystem_Drawable.UsingColor = c;

            }
        }

        public void ChangeTool_Eraser()
        {
            if ( UsingTool != Toolmode.Eraser)
            {
                UsingTool = Toolmode.Eraser;
                InputSystem_Drawable.UsingColor = new Color(255f, 255f, 255f, 0f);
            }
        }



        // Start is called before the first frame update
        void Start()
        {
            //�O�̈׏�����
            UsingTool = Toolmode.Pen;

        }

        // Update is called once per frame
        void Update()
        {

        }

    }

}