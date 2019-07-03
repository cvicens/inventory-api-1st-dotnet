/*
 * Inventory API v2
 *
 * Inventory API for the Cloud Native Workshop
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Coolstore.Inventory.Attributes;
using Coolstore.Inventory.Models;
using Prometheus;

namespace Coolstore.Inventory.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public class DefaultApiController : ControllerBase
    { 
         private Counter apiHttpRequestsTotalCounter;

        public DefaultApiController()
        {
            apiHttpRequestsTotalCounter = Metrics.CreateCounter("api_http_requests_total", "Counts get ...", new CounterConfiguration {
                LabelNames = new[] { "api", "method", "endpoint" }
            });
        }

        /// <summary>
        /// Get all inventory items
        /// </summary>
        /// <remarks>Should return all elements as an array of InventoryItems or an empty array if there are none</remarks>
        /// <response code="200">Should return an arry of InventoryItems</response>
        [HttpGet]
        [Route("/api/inventory")]
        [ValidateModelState]
        [SwaggerOperation("InventoryGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<InventoryItem>), description: "Should return an arry of InventoryItems")]
        public virtual IActionResult InventoryGet()
        { 
            apiHttpRequestsTotalCounter.WithLabels("inventory", "GET", "/api/inventory").Inc();

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<InventoryItem>));

            string exampleJson = null;
            exampleJson = "[{\"itemId\":\"329299\",\"quantity\":35},{\"itemId\":\"329199\",\"quantity\":12},{\"itemId\":\"165613\",\"quantity\":45},{\"itemId\":\"165614\",\"quantity\":87},{\"itemId\":\"165954\",\"quantity\":43},{\"itemId\":\"444434\",\"quantity\":32},{\"itemId\":\"444435\",\"quantity\":53}]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<InventoryItem>>(exampleJson)
            : default(List<InventoryItem>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get one InventoryItem
        /// </summary>
        /// <remarks> Returns the item for the id provided or an error</remarks>
        /// <param name="itemId"></param>
        /// <response code="200">Should return the item for the id provided</response>
        /// <response code="404">Item not found</response>
        [HttpGet]
        [Route("/api/inventory/{itemId}")]
        [ValidateModelState]
        [SwaggerOperation("InventoryItemIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(InventoryItem), description: "Should return the item for the id provided")]
        [SwaggerResponse(statusCode: 404, type: typeof(GenericError), description: "Item not found")]
        public virtual IActionResult InventoryItemIdGet([FromRoute][Required]string itemId)
        { 
             apiHttpRequestsTotalCounter.WithLabels("inventory", "GET", "/api/inventory/{itemId}").Inc();

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(InventoryItem));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(GenericError));

            string exampleJson = null;
            exampleJson = "{\n  \"itemId\" : \"329299\",\n  \"quantity\" : 35\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<InventoryItem>(exampleJson)
            : default(InventoryItem);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
