 BackgroundWorker Worker1 = new BackgroundWorker();
 BackgroundWorker Worker2 = new BackgroundWorker();

                            Worker2.DoWork += (s, e) =>
                             {
                                //Do Your operation
                             };
                            Worker1.DoWork += (s, e) =>
                            {
                                //Do Your operation
                            };
                            if (Worker2.IsBusy == false)
                            {
                                Worker2.RunWorkerAsync();
                            }
                            if (Worker1.IsBusy == false)
                            {
                                Worker1.RunWorkerAsync();

                            }
                            Worker1.RunWorkerCompleted += (s, e) =>
                            {
                                if (Worker2.IsBusy == false)
                                {
                                    //اتمام واکشی
                                    StopFetching();
                                  
                                }

                            };
                            Worker2.RunWorkerCompleted += (s, e) =>
                            {
                                if (Worker1.IsBusy == false)
                                {
                                    //اتمام واکشی
                                    StopFetching();
                                    
                                }

                            };
                       
