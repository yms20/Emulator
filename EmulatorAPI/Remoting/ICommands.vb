Public Interface ICommands

  Sub place(can_id As Integer , location As Double ) 'sets axix there
  Sub drive(can_id As Integer , target As Double ) 'starts controlled movement

  Sub driveLeft (target As XYTCoord ) 'starts controlled movement
  Sub driveRight(target As XYTCoord ) 'starts controlled movement

  Function getCurrentMovingAxis As Integer ' return 0 if nothing is moving ( all jobs are done) OR can_id of axis in motion

End Interface
