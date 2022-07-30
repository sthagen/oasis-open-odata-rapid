# Snapshot report for `tests/MinimalRSDLTest.ts`

The actual snapshot is saved in `MinimalRSDLTest.ts.snap`.

Generated by [AVA](https://ava.li).

## Test minimal set of the RSDL components: RapidID and Required Flags

> Snapshot 1

    `{␊
      "$Version": "4.01",␊
      "$Reference": {␊
        "https://oasis-tcs.github.io/odata-vocabularies/vocabularies/Org.OData.Core.V1.json": {␊
          "$Include": [␊
            {␊
              "$Namespace": "Org.OData.Core.V1",␊
              "$Alias": "Core",␊
              "@Core.DefaultNamespace": true␊
            }␊
          ]␊
        }␊
      },␊
      "RapidModels": {␊
        "RapidContainer": {␊
          "$Kind": "EntityContainer",␊
          "Person": {␊
            "$Type": "RapidModels.Person",␊
            "$Collection": true␊
          }␊
        },␊
        "Person": {␊
          "$Kind": "EntityType",␊
          "$Key": [␊
            "UserName"␊
          ],␊
          "UserName": {␊
            "$Nullable": false␊
          },␊
          "FirstName": {␊
            "$Nullable": true␊
          },␊
          "LastName": {␊
            "$Nullable": false␊
          },␊
          "Value": {␊
            "$Nullable": false,␊
            "$Type": "Edm.Double"␊
          },␊
          "ValueInt": {␊
            "$Nullable": false,␊
            "$Type": "Edm.Int32"␊
          },␊
          "Condition": {␊
            "$Nullable": false,␊
            "$Type": "Edm.Boolean"␊
          },␊
          "StartDate": {␊
            "$Nullable": true,␊
            "$Type": "Edm.Date"␊
          }␊
        }␊
      }␊
    }`