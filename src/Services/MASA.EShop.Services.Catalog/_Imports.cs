﻿global using Dapr;
global using FluentValidation;
global using FluentValidation.AspNetCore;
global using MASA.BuildingBlocks.Dispatcher.Events;
global using MASA.BuildingBlocks.Dispatcher.IntegrationEvents;
global using MASA.Contrib.Data.Uow.EF;
global using MASA.Contrib.Dispatcher.Events;
global using MASA.Contrib.Dispatcher.IntegrationEvents.Dapr;
global using MASA.Contrib.Dispatcher.IntegrationEvents.EventLogs.EF;
global using MASA.Contrib.ReadWriteSpliting.CQRS.Commands;
global using MASA.Contrib.Service.MinimalAPIs;
global using MASA.EShop.Contracts.Catalog;
global using MASA.EShop.Contracts.Ordering;
global using MASA.EShop.Services.Catalog.Application.Catalog;
global using MASA.EShop.Services.Catalog.Application.Catalog.Commands;
global using MASA.EShop.Services.Catalog.Application.CatalogTypes.Commands.CreateCatalogType;
global using MASA.EShop.Services.Catalog.Application.Middleware;
global using MASA.EShop.Services.Catalog.Domain.Entities;
global using MASA.EShop.Services.Catalog.Domain.Repositories;
global using MASA.EShop.Services.Catalog.Infrastructure;
global using MASA.EShop.Services.Catalog.Infrastructure.EntityConfigurations;
global using MASA.EShop.Services.Catalog.Infrastructure.Extensions;
global using MASA.EShop.Services.Catalog.Infrastructure.Repositories;
global using MASA.Utils.Data.EntityFrameworkCore;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using Microsoft.Extensions.Options;
global using Microsoft.OpenApi.Models;
global using System.Globalization;
global using System.IO.Compression;
global using System.Reflection;
global using System.Text.RegularExpressions;
