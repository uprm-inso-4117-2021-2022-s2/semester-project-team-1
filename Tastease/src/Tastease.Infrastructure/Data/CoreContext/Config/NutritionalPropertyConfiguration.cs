﻿using Tastease.Core.RecipeAggregate.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tastease.Core.Literals;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Tastease.Infrastructure.Data.CoreContext.Config;

public class NutritionalPropertyConfiguration : IEntityTypeConfiguration<NutritionalPropertyTable>
{
  public void Configure(EntityTypeBuilder<NutritionalPropertyTable> builder)
  {
    builder.HasKey(x => x.Id);
    builder.Property(x => x.Category)
      .HasConversion(new EnumToStringConverter<NutritionalCategory>());
  }
}

