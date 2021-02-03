## BackendChallengeAPI
In order to test the API, you need to request following URI's:

## List of Products
  * GET => api/products
  
## List of Products filtered
  * GET => api/products/contractlength/{length:int}
  * GET => api/products/renewableRating/{rate:int}
  * GET => api/products/status/{status}
  * GET => api/products/supplier/{supplier}

## Estimated total cost of product
  * GET => api/products/estimatedTotalCost 
  * Send this json from the body in the REQUEST 
      { 
        "id": int /* Product id to check cost */, 
        "estimatedConsumption": double /* Estimated consumption to calculate the cost */
      }
      
## Add Product
  * POST => api/products/add
  * Send this json from the body in teh REQUEST
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
    
## Update Product
    * PUT => api/products/update
    * Send this json from the body in teh REQUEST
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
      
## Delete Product
  * DELETE => api/products/delete/{id:int}
