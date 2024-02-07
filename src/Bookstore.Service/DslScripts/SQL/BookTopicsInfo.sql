SELECT
	b.ID,
	NumberOfTopics = COUNT(bt.ID)
FROM
	Bookstore.Book b
	left join Bookstore.BookTopic bt on bt.BookID = b.ID
GROUP BY
	b.ID