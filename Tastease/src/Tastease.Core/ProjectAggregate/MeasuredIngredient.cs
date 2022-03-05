﻿namespace Tastease.Core.ProjectAggregate;

public class MeasuredIngredient
{
  public Ingredient Ingredient { get; set; }
  public int Quantity { get; set; }
  public MeasurementUnit Unit { get; set; }

}
public enum MeasurementUnit
{
  Ounces, Gallons, Grams, Cups, Teaspoons, Tablespoon, Liters, Milliters
}

