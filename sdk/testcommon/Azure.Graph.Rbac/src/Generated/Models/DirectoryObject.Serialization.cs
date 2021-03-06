// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Graph.Rbac.Models
{
    public partial class DirectoryObject
    {
        internal static DirectoryObject DeserializeDirectoryObject(JsonElement element)
        {
            if (element.TryGetProperty("objectType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Application": return Application.DeserializeApplication(element);
                    case "Group": return ADGroup.DeserializeADGroup(element);
                    case "ServicePrincipal": return ServicePrincipal.DeserializeServicePrincipal(element);
                    case "User": return User.DeserializeUser(element);
                }
            }
            Optional<string> objectId = default;
            Optional<string> objectType = default;
            Optional<DateTimeOffset> deletionTimestamp = default;
            IReadOnlyDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("objectId"))
                {
                    objectId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectType"))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deletionTimestamp"))
                {
                    deletionTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DirectoryObject(objectId.Value, objectType.Value, Optional.ToNullable(deletionTimestamp), additionalProperties);
        }
    }
}
