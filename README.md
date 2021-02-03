## BackendChallengeAPI
In order to test the API, you need to start the project and REQUEST following URI's (Postman client recommended):

## List of Products
  * GET => api/products
  
## List of Products filtered
  * GET => api/products/contractlength/{length:int}
  * GET => api/products/renewableRating/{rate:int}
  * GET => api/products/status/{status:string}
  * GET => api/products/supplier/{supplier:string}

## Estimated total cost of product
  * GET => api/products/estimatedTotalCost 
  * Send this json from the body in the REQUEST 
  ```json    
      { 
        "id": int /* Product id to check cost */, 
        "estimatedConsumption": double /* Estimated consumption to calculate the cost */
      }
  ```
      
## Add Product
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
  * DELETE => api/products/delete/{id:int}
