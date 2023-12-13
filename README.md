1. Основа - два интерфейса IFigure и IFigureService.
2. Главная абстракция FigureBase (чтобы не использовать фабрику).
3. Фигуры добавляются простым наследованием от FigureBase (см. Figures\FiguresCommon\Concrete\Fugures).
4. Расчёт площади фигуры CalculateSquare(IFigure figure).
5. Декомпоциция: Point -> Vector -> Dimensions -> Figure.
   
