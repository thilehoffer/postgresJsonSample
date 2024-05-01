select  book_id
,title
,book_details
,book_details->'Rating'
, jsonb_array_elements(book_details->'Authors')
from public.books
LIMIT 1000