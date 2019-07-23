module Catalog.Types

type Product = { id: string; name: string; description: string; price: float }

type Msg =
| GetPagedCatalog of page: int * pageSize: int
| PagedCatalogFullfiled of page: int * pageSize: int