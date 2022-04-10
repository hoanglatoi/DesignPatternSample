using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbtractFactory
{
    #region Chair
    public interface IChair
    {
        public void Create();
    }
    
    public class PlasticChair : IChair
    {
        public void Create()
        {
            Console.WriteLine("plastic chair is created");
        }
    }

    public class WoodChair : IChair
    {
        public void Create()
        {
            Console.WriteLine("wood chair is created");
        }
    }
    #endregion


    #region Table
    public interface ITable
    {
        public void Create();
    }
    //Table:
    public class PlaticTable : ITable
    {
        public void Create()
        {
            Console.WriteLine("plastic table is created");
        }
    }

    public class WoodTable : ITable
    {
        public void Create()
        {
            Console.WriteLine("wood table is created");
        }
    }
    #endregion

    #region AbstractFactory
    // Facroty class
    //AbstractFactory
    public abstract class FurnitureAbstractFactory
    {

        public abstract IChair CreateObjChair();

        public abstract ITable CreateObjTable();

    }

    public class PlasticFactory : FurnitureAbstractFactory
    {
        public override IChair CreateObjChair()
        {
            return new PlasticChair();
        }

        public override ITable CreateObjTable()
        {
            return new PlaticTable();
        }
    }

    public class WoodFactory : FurnitureAbstractFactory
    {
        public override IChair CreateObjChair()
        {
            return new WoodChair();
        }

        public override ITable CreateObjTable()
        {
            return new WoodTable();
        }
    }
    #endregion

    //Material type:
    public enum MaterialType
    {
        FLASTIC, 
        WOOD
    }

    public class FurnitureFactory
    {

        private FurnitureFactory()
        {

        }

        // Returns a concrete factory object that is an instance of the
        // concrete factory class appropriate for the given architecture.
        public static FurnitureAbstractFactory? GetFactory(MaterialType materialType)
        {
            switch (materialType)
            {
                case MaterialType.FLASTIC:
                    return new PlasticFactory();
                case MaterialType.WOOD:
                    return new WoodFactory();
                default:
                    return null;
            }
        }
    }

    //internal class AbtractFactory
    //{
    //}
}
