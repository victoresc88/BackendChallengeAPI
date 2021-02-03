## BackendChallengeAPI
This API has a series of endpoints that returning different results (check the ProductController class)
In order to test the API, you need to start the project and REQUEST following URI's (Postman client recommended)

## List of Products
Returns a list of all products (automatically mocked when starting the project):
  * GET => api/products
  
## List of Products filtered
Returns a list of filtered products:
  * GET => api/products/contractlength/{length:int}
  * GET => api/products/renewableRating/{rate:int}
  * GET => api/products/status/{status:string}
  * GET => api/products/supplier/{supplier:string}

## Estimated total cost of product
Returns the estimated total cost for a period of 12, given a Product id and an Estimated Consumption:
  * GET => api/products/estimatedTotalCost 
  * Send this json from the body in the REQUEST 
  ```json    
      { 
        "id": int /* Product id to check cost */, 
        "estimatedConsumption": double /* Estimated consumption to calculate the cost */
      }
  ```
      
## Add Product
Adds a product to the list, returns true or false if it has been added or not:
  * POST => api/products/add
  * Send this json from the body in the REQUEST
  ```json
      {
        "id": int,
        "supplier" : string,
        "name" : "string,
        "rate" : double,
        "dailystandingcharge": double,
        "contractlength" : int,
        "renewable": int,
        "status": string
      }
   ```
    
## Update Product
Updates a product with an existing Id, changing all the parameters modified, returns true or false:
   * PUT => api/products/update
   * Send this json from the body in the REQUEST
   ```json
       {
          "id": int,
          "supplier" : string,
          "name" : "string,
          "rate" : double,
          "dailystandingcharge": double,
          "contractlength" : int,
          "renewable": int,
          "status": string
        }
   ```
       
## Delete Product
Deletes a product given a Product Id, returns true or false:
  * DELETE => api/products/delete/{id:int}
