using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


namespace FreeDraw
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
            first,
            second,
            third
        }
        public ColorPicker CurColor = ColorPicker.first;

        // �I���c�[����L����
        private void ToolActivator ( Toolmode SelTool )
        {
            switch (SelTool)
            {
                case Toolmode.Pen:
                    UsingTool = Toolmode.Pen;
                    //CurrentTool.transform.Translate(-305, 191, 0);
                    break;

                case Toolmode.Highlighter:
                    UsingTool = Toolmode.Highlighter;
                    //CurrentTool.transform.Translate(-249, 191, 0);
                    break;

                case Toolmode.Eraser:
                    UsingTool = Toolmode.Eraser;
                    //CurrentTool.transform.Translate(-192, 191, 0);
                    break;

                case Toolmode.Constractions:
                    UsingTool = Toolmode.Constractions;
                    //CurrentTool.transform.Translate(252, 191, 0);
                    break;

            }
        }

        //// �I���J���[�s�b�J�[��L����
        //void ColorActivator(ColorPicker SelColor)
        //{

        //}

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


        // �c�[�����I�����ꂽ�Ƃ��̏���
        public void ChangeTool( Toolmode SelTool )
        {
            // �I���c�[�����I�𒆂̃c�[���Ɠ���������
            if ( SelTool != UsingTool)
            {
                // ToolActivator�̋N���Ƃ�
                switch (SelTool)
                {
                    case Toolmode.Pen:
                        ToolActivator(SelTool);
                    break;

                    case Toolmode.Highlighter:
                        ToolActivator(SelTool);
                    break;

                    case Toolmode.Eraser:
                        ToolActivator(SelTool);
                    break;

                    case Toolmode.Constractions:
                        ToolActivator(SelTool);
                    break;

                }
            }
            // �����̕ύX����
            else if ( SelTool != Toolmode.Constractions)
            {

            }
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