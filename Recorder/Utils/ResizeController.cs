using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Recorder.Utils
{
    public class ResizeController
    {
        public ResizeController(Form form)
        {
            _form = form;
        }
        Form _form;
        int _leftBeforMove;
        int _topBeforMove;
        EMouseDownDownType _currentDownType = EMouseDownDownType.None;

        public void Set(EMouseDownDownType pDownType)
        {
            _currentDownType = pDownType;
        }

        public void Move()
        {
            _leftBeforMove = _form.Left;
            _topBeforMove = _form.Top;
            switch (_currentDownType)
            {
                case EMouseDownDownType.BorderLeft:
                    _form.Left = Form.MousePosition.X;
                    _form.Width -= _form.Left - _leftBeforMove;
                    break;
                case EMouseDownDownType.BorderRight:
                    _form.Width += Form.MousePosition.X - _form.Left - _form.Width;
                    break;
                case EMouseDownDownType.BorderLeftBottom: 
                    _form.Left = Form.MousePosition.X;
                    _form.Width -= _form.Left - _leftBeforMove;
                    _form.Height += Form.MousePosition.Y - _form.Top - _form.Height;
                    break;
                case EMouseDownDownType.BorderRightBottom:
                    _form.Width += Form.MousePosition.X - _form.Left - _form.Width;
                    _form.Height += Form.MousePosition.Y - _form.Top - _form.Height;
                    break;
                case EMouseDownDownType.BorderBottom:
                    _form.Height += Form.MousePosition.Y - _form.Top-_form.Height;
                    break;
                case EMouseDownDownType.TitleTop:
                     _form.Top = Form.MousePosition.Y;
                    _form.Height -= _form.Top - _topBeforMove;
                    break;
                case EMouseDownDownType.TitleLeft: 
                    _form.Top = Form.MousePosition.Y;
                    _form.Height -= _form.Top - _topBeforMove;
                     _form.Left = Form.MousePosition.X;
                    _form.Width -= _form.Left - _leftBeforMove;
                    break;
                case EMouseDownDownType.TitleRight:
                    _form.Top = Form.MousePosition.Y;
                    _form.Height -= _form.Top - _topBeforMove;
                    _form.Width += Form.MousePosition.X - _form.Left - _form.Width;
                    break;

            }
        }

    }

    /// <summary>
    /// 窗体边缘鼠标左键按下的区域
    /// </summary>
    public enum EMouseDownDownType
    {
        None = 0,
        BorderLeft,
        BorderRight,
        BorderBottom,
        BorderLeftBottom,
        BorderRightBottom,
        TitleTop,
        TitleLeft,
        TitleRight
    }
}
