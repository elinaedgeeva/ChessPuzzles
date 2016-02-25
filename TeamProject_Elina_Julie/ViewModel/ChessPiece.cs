using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows;
using TeamProject_Elina_Julie.Model;

namespace TeamProject_Elina_Julie
{
    class ChessPiece: ViewModelBase
    {
        private Point _Pos;
        public Point Pos
        {
            get { return this._Pos; }
            set { this._Pos = value; RaisePropertyChanged(() => this.Pos); }
        }

        private PieceType _Type;
        public PieceType Type
        {
            get { return this._Type; }
            set { this._Type = value; RaisePropertyChanged(() => this.Type); }
        }

        private Player _Player;
        public Player Player
        {
            get { return this._Player; }
            set { this._Player = value; RaisePropertyChanged(() => this.Player); }
        }
    }
}
