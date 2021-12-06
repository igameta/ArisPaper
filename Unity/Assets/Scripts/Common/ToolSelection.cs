using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


namespace Drawing
{
    public class ToolSelection : MonoBehaviour
    {
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

        // �I�𒆂̐F�̕ێ�
        public enum ColorPicker
        {
            first=0,
            second=1,
            third=2
        }
        public static ColorPicker CurColor = ColorPicker.first;

        // CurColorGetter
        public static int GetCurColor()
        {
            return (int)CurColor;
        }

        //////////////////////////////////////////////////////////////
        /// �y���̐ݒ�Ƃ�

        // �y���ނ̑���
        public double Pen_weidth = 1.0;
        public double High_weidth = 2.5;

        // �c�[���ύX
        public void ChangeTool_Pen()
        {
            if ( UsingTool != Toolmode.Pen)
            {
                UsingTool = Toolmode.Pen;

            }
        }

        public void ChangeTool_High()
        {
            if ( UsingTool != Toolmode.Highlighter)
            {
                UsingTool = Toolmode.Highlighter;

            }
        }

        public void ChangeTool_Eraser()
        {
            if ( UsingTool=Toolmode.Eraser)
            {
                UsingTool = Toolmode.Eraser;

            }
        }

        public void ChangeTool_Constraction()
        {

        }

        // Start is called before the first frame update
        void Start()
        {
            //�O�̈׏�����
            UsingTool = Toolmode.Pen;
            CurColor = ColorPicker.first;

            // �{�^���������m
            //Button btn = ToolSelection.GetComponent<Button>();
            //btn.onClick.AddListener(TaskOnClick);
        }



        // �J���[�s�b�J�[�������ꂽ�Ƃ��̏���
        //public void ChangeColorPicker ( ColorPicker SelPicker )
        //{
        //    if ( CurColor != SelPicker)
        //    {

        //    }
        //}

        // Update is called once per frame
        void Update()
        {

        }

    }

}