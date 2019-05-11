﻿using NIK.BoulderDash.Logic.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NIK.BoulderDash.Logic
{
    public class Firefly : Enemie
    {
        public Firefly(Point initPosition)
        {
            TilePosition = initPosition;
            TileOldPosition = initPosition;
        }

        Direction faceDirection= Direction.Down;
        private Direction GetLeft()
        {
            if (faceDirection == Direction.Left)
                return Direction.Down;
            else if(faceDirection==Direction.Down)
                return Direction.Right;
            else if (faceDirection == Direction.Right)
                return Direction.Up;
            else if (faceDirection == Direction.Up)
                return Direction.Left;
            throw new Exception("Bad direction");
        }
        private Direction GetRight()
        {
            if (faceDirection == Direction.Left)
                return Direction.Up;
            else if (faceDirection == Direction.Down)
                return Direction.Left;
            else if (faceDirection == Direction.Right)
                return Direction.Down;
            else if (faceDirection == Direction.Up)
                return Direction.Right;
            throw new Exception("Bad direction");
        }

        public Point unit(Direction dir)
        {
            if(faceDirection == Direction.Up)
            {
                if (dir == Direction.Left)
                {
                    return new Point(TilePosition.X - 1, TilePosition.Y);
                }
                else if(dir == Direction.Right)
                {
                    return new Point(TilePosition.X + 1, TilePosition.Y);
                }
                else if (dir == Direction.Up)
                {
                    return new Point(TilePosition.X, TilePosition.Y-1);
                }
                else if (dir == Direction.Down)
                {
                    return new Point(TilePosition.X, TilePosition.Y+1);
                }
            }
            else if(faceDirection == Direction.Down)
            {
                if (dir == Direction.Left)
                {
                    return new Point(TilePosition.X + 1, TilePosition.Y);
                    
                }
                else if (dir == Direction.Right)
                {
                    return new Point(TilePosition.X - 1, TilePosition.Y);
                }
                else if (dir == Direction.Up)
                {
                    return new Point(TilePosition.X, TilePosition.Y + 1);
                }
                else if (dir == Direction.Down)
                {
                    return new Point(TilePosition.X, TilePosition.Y - 1);
                }
            }
            else if(faceDirection == Direction.Left)
            {
                if (dir == Direction.Left)
                {
                    return new Point(TilePosition.X, TilePosition.Y + 1);
                }
                else if (dir == Direction.Right)
                {
                    return new Point(TilePosition.X, TilePosition.Y - 1);
                    
                }
                else if (dir == Direction.Up)
                {
                    return new Point(TilePosition.X - 1, TilePosition.Y);
                    
                }
                else if (dir == Direction.Down)
                {
                    return new Point(TilePosition.X + 1, TilePosition.Y);
                }
            }
            else if(faceDirection == Direction.Right)
            {
                if (dir == Direction.Left)
                {
                    return new Point(TilePosition.X, TilePosition.Y - 1);
                }
                else if (dir == Direction.Right)
                {
                    return new Point(TilePosition.X, TilePosition.Y + 1);
                }
                else if (dir == Direction.Up)
                {
                    return new Point(TilePosition.X + 1, TilePosition.Y);
                }
                else if (dir == Direction.Down)
                {
                    return new Point(TilePosition.X - 1, TilePosition.Y);
                }
            }
            return new Point(0, 0);
            
        }
        public override void Step(bool[,] obstacle)
        {
            var primTarget = unit(Direction.Left);
            var secTarget = unit(Direction.Up);
            if (!obstacle[(int)primTarget.X, (int)primTarget.Y])
            {
                faceDirection = GetLeft();
                move(primTarget);
            }
            else if(!obstacle[(int)secTarget.X, (int)secTarget.Y])
            {
                move(secTarget);
            }
            else
            {
                faceDirection = GetRight();
            }
        }

        private void move(Point p)
        {
            TileOldPosition = TilePosition;
            TilePosition.X = p.X;
            TilePosition.Y = p.Y;
            
        } 
    }
}
