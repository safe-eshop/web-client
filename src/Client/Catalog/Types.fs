module Catalog.Types

type Product = { id: string; name: string; description: string; price: float }

type Msg =
| GetAllProducts of page: int * pageSize: int