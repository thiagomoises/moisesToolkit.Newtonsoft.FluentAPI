﻿using Newtonsoft.FluentAPI.Abstracts;
using Newtonsoft.FluentAPI.Builders;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Newtonsoft.FluentAPI.Tests
{
    public class TestJsonTypeConfiguration : IJsonTypeConfiguration<UserTest>
    {
        public void Configure(JsonTypeBuilder<UserTest> jsonTypeBuilder)
        {
            jsonTypeBuilder.Property(x => x.FirstName)
                .HasFieldName("first_name");

            jsonTypeBuilder.Property(x => x.Nickname)
                .HasFieldName("nickname")
                .AddNullValueHandling(Json.NullValueHandling.Ignore)
                .AddDefaultValueHandling(Json.DefaultValueHandling.Include);

            jsonTypeBuilder.Property(x => x.LastName)
                .HasFieldName("last_name");

            jsonTypeBuilder.Property(x => x.Age)
                .HasFieldName("user_age");

            jsonTypeBuilder.Property(x => x.Status)
                .HasFieldName("status")
                .HasConverter(new StringEnumConverter());

            jsonTypeBuilder.Property(x => x.City)
                .IsIgnored();

            jsonTypeBuilder.Property(x => x.IsAdmin)
                .HasFieldName("is_admin")
                .AddDefaultValueHandling(Json.DefaultValueHandling.Include);
        }
    }
}
