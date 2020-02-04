using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IClothesFactory
{
    IClothes Create(ClothesRequirements requirements);
}



public class ClothesFactory // : AbstractClothesFactory
{


    private readonly IClothesFactory _factory;
    private readonly ClothesRequirements _requirements;
    
    public ClothesFactory(ClothesRequirements requirements)
    {
        _factory = requirements.Woman ? (IClothesFactory) new WomenFactory() : new MenFactory();
        _requirements = requirements;
    }

    public IClothes Create()
    {
        return _factory.Create(_requirements);
    }
}

public class WomenFactory : IClothesFactory
{
    public IClothes Create(ClothesRequirements requirements)
    {
        switch (requirements.Location)
        {
            case 1:
                return new Swimwear();
            case 2:
				if(requirements.Formal)
				{
					return new EveningDress();
				}
				else
				{
					return new CocktailDress();
					
				}
                return new DressyCasual();
            case 3:
				if (requirements.Formal)
				{
					return new BusinessProfessional();
				}
				else 
				{
					return new BusinessCasual();
				}
                return new DressyCasual();
            case 4:
                if (requirements.Formal)
				{
					return new SunDress();
				}
				else 
				{
					return new CasualWear();
				}
            default:
                return new CasualWear();
			
		}
	}
}

public class MenFactory : IClothesFactory
{
    public IClothes Create(ClothesRequirements requirements)
    {
        switch (requirements.Location)
        {
            case 1:
                return new Swimwear();
            case 2:
				if(requirements.Formal)
				{
					return new Tuxedo();
				}
				else
				{ 
					return new DressyCasual();
				}
                return new DressyCasual();
            case 3:
				if (requirements.Formal)
				{
					return new BusinessProfessional();
				}
				else 
				{
					return new BusinessCasual();
				}
                return new DressyCasual();
            case 4:
                if (requirements.Formal)
				{
					return new DressyCasual();
				}
				else 
				{
					return new CasualWear();
				}
				
            default:
                return new CasualWear();
        }
    }
}
